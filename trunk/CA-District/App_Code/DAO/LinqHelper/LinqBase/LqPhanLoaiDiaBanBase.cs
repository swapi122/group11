




/*
'===============================================================================
'  LinqHelper.DAO.PhanLoaiDiaBanBase
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
	public class LqPhanLoaiDiaBanBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiDiaBanBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqPhanLoaiDiaBanEntity obj)
		{
			provider.GetTable<LqPhanLoaiDiaBanEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqPhanLoaiDiaBanEntity _obj)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqPhanLoaiDiaBanEntity tmp = q.First<LqPhanLoaiDiaBanEntity>();
			
			tmp.TenPhanLoaiDiaBan = _obj.TenPhanLoaiDiaBan;
			tmp.IdMaCha = _obj.IdMaCha;
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
		
		public void Delete(LqPhanLoaiDiaBanEntity obj)
		{
			provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenPhanLoaiDiaBan(string TenPhanLoaiDiaBan)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.TenPhanLoaiDiaBan == TenPhanLoaiDiaBan
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqPhanLoaiDiaBanEntity ob = (LqPhanLoaiDiaBanEntity)q.First<LqPhanLoaiDiaBanEntity>();
            provider.GetTable<LqPhanLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqPhanLoaiDiaBanEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqPhanLoaiDiaBanEntity>();
		}

		public List<LqPhanLoaiDiaBanEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByTenPhanLoaiDiaBan(string TenPhanLoaiDiaBan)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.TenPhanLoaiDiaBan == TenPhanLoaiDiaBan
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		public List<LqPhanLoaiDiaBanEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDiaBanEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqPhanLoaiDiaBanEntity>();
		}
		
		
		

	}
}
