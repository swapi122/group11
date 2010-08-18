




/*
'===============================================================================
'  LinqHelper.DAO.KhamPhaBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqKhamPhaBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKhamPhaBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqKhamPhaEntity obj)
		{
			provider.GetTable<LqKhamPhaEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqKhamPhaEntity _obj)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqKhamPhaEntity tmp = q.First<LqKhamPhaEntity>();
			
			tmp.TenKhamPha = _obj.TenKhamPha;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqKhamPhaEntity obj)
		{
			provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenKhamPha(string TenKhamPha)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.TenKhamPha == TenKhamPha
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqKhamPhaEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqKhamPhaEntity ob = (LqKhamPhaEntity)q.First<LqKhamPhaEntity>();
            provider.GetTable<LqKhamPhaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqKhamPhaEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqKhamPhaEntity>();
		}

		public List<LqKhamPhaEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByTenKhamPha(string TenKhamPha)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.TenKhamPha == TenKhamPha
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		public List<LqKhamPhaEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqKhamPhaEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqKhamPhaEntity>();
		}
		
		
		

	}
}
