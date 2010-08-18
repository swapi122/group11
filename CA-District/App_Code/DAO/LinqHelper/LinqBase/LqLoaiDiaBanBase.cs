




/*
'===============================================================================
'  LinqHelper.DAO.LoaiDiaBanBase
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
	public class LqLoaiDiaBanBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiDiaBanBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqLoaiDiaBanEntity obj)
		{
			provider.GetTable<LqLoaiDiaBanEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqLoaiDiaBanEntity _obj)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqLoaiDiaBanEntity tmp = q.First<LqLoaiDiaBanEntity>();
			
			tmp.TenLoaiDiaBan = _obj.TenLoaiDiaBan;
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
		
		public void Delete(LqLoaiDiaBanEntity obj)
		{
			provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenLoaiDiaBan(string TenLoaiDiaBan)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.TenLoaiDiaBan == TenLoaiDiaBan
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqLoaiDiaBanEntity ob = (LqLoaiDiaBanEntity)q.First<LqLoaiDiaBanEntity>();
            provider.GetTable<LqLoaiDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqLoaiDiaBanEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqLoaiDiaBanEntity>();
		}

		public List<LqLoaiDiaBanEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByTenLoaiDiaBan(string TenLoaiDiaBan)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.TenLoaiDiaBan == TenLoaiDiaBan
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		public List<LqLoaiDiaBanEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqLoaiDiaBanEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqLoaiDiaBanEntity>();
		}
		
		
		

	}
}
